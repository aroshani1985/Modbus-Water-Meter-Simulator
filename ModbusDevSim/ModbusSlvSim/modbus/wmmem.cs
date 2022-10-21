using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusSlvSim.modbus
{
    public class wmmem
    {
        #region Consts
        const int ADD_COIL_BEGIN = 1;
        const int ADD_COIL_END = 10000;

        const int ADD_INPUT_DISCETE_GEGIN = 10001;
        const int ADD_INPUT_DISCETE_END = 20000;

        const int ADD_INPUT_REGISTER_GEGIN = 30001;
        const int ADD_INPUT_REGISTER_END = 40000;

        const int ADD_HOLDING_REGISTER_GEGIN = 40001;
        const int ADD_HOLDING_REGISTER_END = 50000;
        #endregion

        #region Variable Addresses
        const int ADD_IR_VOLUME_U32 = 30001;  //m3
        const int LEN_IR_VOLUME_U32 = 4;

        const int ADD_IR_FLOWRATE_F = ADD_IR_VOLUME_U32 + LEN_IR_VOLUME_U32;  //m3/h
        const int LEN_IR_FLOWRATE_F = 4;

        const int ADD_IR_TEMPERATURE_F = ADD_IR_FLOWRATE_F + LEN_IR_FLOWRATE_F;  //m3/h
        const int LEN_IR_TEMPERATURE_F = 4;
        #endregion

        #region 
        public wmmem()
        {

        }
        #endregion

        #region 
        #endregion
    }
}
