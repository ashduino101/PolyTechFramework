using System.IO;
using System.Collections.Generic;
using PolyTechFramework;

namespace PolyTechFramework
{
    class PolyTechUtils
    {
        public static void setModdedSimSpeeds()
        {
            BridgeSimSpeed.m_DefaultSimulationSpeedIndex = 5;
            BridgeSimSpeed.m_SimulationSpeeds = new List<float>
            {
                0.0000001f,
                0.05f,
                0.1f,
                0.2f,
                0.5f,
                1f,
                2f,
                3f,
                6f,
                12f,
                24f
            };
        }
        public static void setVanillaSimSpeeds()
        {
            BridgeSimSpeed.m_DefaultSimulationSpeedIndex = 2;
            BridgeSimSpeed.m_SimulationSpeeds = new List<float>
            {
                0.2f,
                0.5f,
                1f,
                2f,
                3f
            };
        }
        public static void setVersion()
        {
        }
    }
}
