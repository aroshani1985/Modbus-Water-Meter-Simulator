using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        byte _err_code;
        byte _fcn_code;
        UInt16 _crc;
        #endregion

        #region Constructors
        public mbcore()
        {
            _mb_address = DEFAULT_SLAVE_ADDRESS;
        }

        public mbcore(byte SlaveAddress)
        {
            _mb_address = SlaveAddress;
        }
        #endregion

        #region Methods
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
            if(!get_modbus_crc(_mb_rec_pkt))
            {
                _err_code = 3;
                return _err_code;
            }
            
            if(!process_function_code(_mb_rec_pkt[1]))
            {
                _err_code = 4;
                return _err_code;
            }
            return _err_code;
        }

        bool get_modbus_crc(byte[] buf)
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
