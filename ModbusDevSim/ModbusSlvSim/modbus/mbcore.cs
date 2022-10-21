using ModbusSlvSim.spx;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusSlvSim.modbus
{
    public class mbcore
    {
        #region CONSTS
        const byte DEFAULT_SLAVE_ADDRESS = 1;
        #endregion

        #region Type definitions
        public enum ModbusFcnCode:byte
        {
            ReadCoil = 1,
            ReadDiscreteInput = 2,
            ReadHoldingRegisters = 3,
            ReadInputRegisters = 4,
            WriteSingleCoil = 5,
            WriteSingleHoldingRegister = 6,
            WriteMultipleCoils = 15,
            WriteMultipleHoldingRegisters = 16
        }
        #endregion

        #region Fields
        byte _mb_address;
        byte[] _mb_rec_pkt;
        byte[] _mb_rep_pkt;
        byte _err_code;
        byte _fcn_code;
        UInt16 _add_reg;
        UInt16 _len_data;
        UInt16 _crc;
        byte _crc_h;
        byte _crc_l;
        sp _sp;
        RichTextBox _rtb;
        sputil _sput;
        #endregion

        #region Constructors
        public mbcore(sp spx, RichTextBox rtb)
        {
            _mb_address = DEFAULT_SLAVE_ADDRESS;
            _rtb = rtb;
            _sp = spx;
            _sput = new sputil();
        }

        public mbcore(byte SlaveAddress, sp spx, RichTextBox rtb)
        {
            _mb_address = SlaveAddress;
            _rtb = rtb;
            _sp = spx;
            _sput = new sputil();
        }
        #endregion

        #region Methods - Process Request 
        public byte process_packet(byte[] Packet)
        {
            _err_code = 0;
            _mb_rec_pkt = Packet;
            if(_mb_rec_pkt.Length < 5)
            {
                _err_code = 1;
                return _err_code;
            }
            if (_mb_rec_pkt[0] != _mb_address)
            {
                _err_code = 2;
                return _err_code;
            }
            if(!check_modbus_crc(_mb_rec_pkt))
            {
                _err_code = 3;
                return _err_code;
            }
            if (!process_packet_parameters())
            {
                _err_code = 4;
                return _err_code;
            }
            if (process_function_code(_mb_rec_pkt[1]))
            {
                
                return _err_code;
            }
            else
            {
                _err_code = 5;
                error_invalid_add_reply();
            }
           
            return _err_code;
        }

        bool check_modbus_crc(byte[] buf)
        {
            _crc = 0xFFFF;
            int len = buf.Length - 2;
            for (int pos = 0; pos < len; pos++)
            {
                _crc ^= (UInt16)buf[pos];          // XOR byte into least sig. byte of crc

                for (int i = 8; i != 0; i--)
                {    // Loop over each bit
                    if ((_crc & 0x0001) != 0)
                    {      // If the LSB is set
                        _crc >>= 1;                    // Shift right and XOR 0xA001
                        _crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                        _crc >>= 1;                    // Just shift right
                }
            }
            // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
            if (((_crc >> 8) & 0xFF) == buf[buf.Length - 1] && (_crc & 0xFF) == buf[buf.Length - 2])
                return true;
            else
                return false;
        }

        void make_modbus_crc(ref byte[] buf)
        {
            _crc = 0xFFFF;
            int len = buf.Length - 2;
            for (int pos = 0; pos < len; pos++)
            {
                _crc ^= (UInt16)buf[pos];          // XOR byte into least sig. byte of crc

                for (int i = 8; i != 0; i--)
                {    // Loop over each bit
                    if ((_crc & 0x0001) != 0)
                    {      // If the LSB is set
                        _crc >>= 1;                    // Shift right and XOR 0xA001
                        _crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                        _crc >>= 1;                    // Just shift right
                }
            }
            // Note, this number has low and high bytes swapped, so use it accordingly (or swap bytes)
            _crc_h = (byte)((_crc >> 8) & 0xFF);
            _crc_l = (byte)(_crc & 0xFF); // comes fiest 
            buf[buf.Length - 2] = _crc_l;
            buf[buf.Length - 1] = _crc_h;
        }

        bool process_function_code(byte FunctionCode)
        {
            bool is_fcn_valid = true;
            _fcn_code = FunctionCode;
            switch (_fcn_code)
            {
                case (byte)ModbusFcnCode.ReadCoil:
                    break;

                case (byte)ModbusFcnCode.ReadDiscreteInput:
                    break;

                case (byte)ModbusFcnCode.ReadHoldingRegisters:
                    break;

                case (byte)ModbusFcnCode.ReadInputRegisters:
                    reply_input_register();
                    break;

                case (byte)ModbusFcnCode.WriteSingleCoil:
                    break;

                case (byte)ModbusFcnCode.WriteSingleHoldingRegister:
                    break;

                case (byte)ModbusFcnCode.WriteMultipleCoils:
                    break;

                case (byte)ModbusFcnCode.WriteMultipleHoldingRegisters:
                    break;

                default:
                    is_fcn_valid = false;
                    break;
            }
            return is_fcn_valid;
        }

        bool process_packet_parameters()
        {
            _add_reg = _mb_rec_pkt[2];
            _add_reg <<= 8;
            _add_reg |= _mb_rec_pkt[3];
            _add_reg++;

            if (_add_reg > 6)
                return false;

            _len_data = _mb_rec_pkt[4];
            _len_data <<= 8;
            _len_data |= _mb_rec_pkt[5];

            if (_len_data > 6)
                return false;

            return true;
        }
        void error_invalid_add_reply()
        {
            _mb_rep_pkt = new byte[5];
            _mb_rep_pkt[0] = _mb_address;
            _mb_rep_pkt[1] = (byte)(128 + _fcn_code);
            _mb_rep_pkt[2] = 0x02; //invalid address code 
            make_modbus_crc(ref _mb_rep_pkt);
            send_packet();
        }
        void reply_input_register()
        {
            int data_len = _len_data * 2;
            _mb_rep_pkt = new byte[5 + data_len];
            _mb_rep_pkt[0] = _mb_address;
            _mb_rep_pkt[1] = _fcn_code;
            _mb_rep_pkt[2] = (byte)data_len; //Data len
            switch (_add_reg)
            {
                case 1:
                    fill_float(1.687f, 3, true);
                    if (_len_data >=4)
                        fill_float(15.687f, 7, true);
                    if(_len_data>=6)
                        fill_float(124.987f, 11, true);
                    break;

                case 2:
                    fill_float(15.687f, 3, true);
                    if(_len_data >=4)
                        fill_float(124.987f, 7, true);
                    break;

                case 3:
                    fill_float(124.987f, 3, true);
                    break;
                default:
                    break;

            }
            make_modbus_crc(ref _mb_rep_pkt);
            send_packet();
        }
        void reply_Input_Register_float(float value)
        {
            _mb_rep_pkt = new byte[5 + 4];
            _mb_rep_pkt[0] = _mb_address;
            _mb_rep_pkt[1] = _fcn_code;
            _mb_rep_pkt[2] = 0x04; //Data len

            byte[] single_percision_float = BitConverter.GetBytes(value);
            //little endian  LSRF modscan
            /*
            _mb_rep_pkt[3] = single_percision_float[1];
            _mb_rep_pkt[4] = single_percision_float[0];
            _mb_rep_pkt[5] = single_percision_float[3];
            _mb_rep_pkt[6] = single_percision_float[2];
            */

            //big endian   MSRF modscan
            
            _mb_rep_pkt[3] = single_percision_float[3];
            _mb_rep_pkt[4] = single_percision_float[2];
            _mb_rep_pkt[5] = single_percision_float[1];
            _mb_rep_pkt[6] = single_percision_float[0];
            

            make_modbus_crc(ref _mb_rep_pkt);
            send_packet();
        }
        void send_packet()
        {
            if (_sp.Is_Port_Open)
            {
                _sp.SendArray(_mb_rep_pkt, _mb_rep_pkt.Length);
                _sput.SetRichText(_rtb, "Slave Reply: " + BitConverter.ToString(_mb_rep_pkt), Color.Aqua);
            }
        }
        #endregion

        #region Prepare reply
        void fill_u16(byte value, int start_idx)
        {
            _mb_rep_pkt[start_idx] = value;
        }
        void fill_u16(UInt16 value, int start_idx)
        {
            _mb_rep_pkt[start_idx] = (byte)(value >> 8 & 0xFF);
            _mb_rep_pkt[start_idx + 1] = (byte)(value >> 0 & 0xFF);
        }
        void fill_u32(UInt32 value, int start_idx)
        {
            _mb_rep_pkt[start_idx] = (byte)(value >> 8 & 0xFF);
            _mb_rep_pkt[start_idx+1] = (byte)(value >> 0 & 0xFF);
            _mb_rep_pkt[start_idx+2] = (byte)(value >> 24 & 0xFF);
            _mb_rep_pkt[start_idx+3] = (byte)(value >> 16 & 0xFF); ;
        }
        void fill_float(float value, int start_idx, bool is_le)
        {
            byte[] single_percision_float = BitConverter.GetBytes(value);
            if(is_le)
            {
                _mb_rep_pkt[start_idx] = single_percision_float[1];
                _mb_rep_pkt[start_idx + 1] = single_percision_float[0];
                _mb_rep_pkt[start_idx + 2] = single_percision_float[3];
                _mb_rep_pkt[start_idx + 3] = single_percision_float[2];
            }
            else
            {
                _mb_rep_pkt[start_idx] = single_percision_float[3];
                _mb_rep_pkt[start_idx + 1] = single_percision_float[2];
                _mb_rep_pkt[start_idx + 2] = single_percision_float[1];
                _mb_rep_pkt[start_idx + 3] = single_percision_float[0];
            }
        }
        #endregion


        #region Properties
        public byte ErrorCode
        {
            get
            {
                return _err_code;
            }
        }
        #endregion
    }
}
