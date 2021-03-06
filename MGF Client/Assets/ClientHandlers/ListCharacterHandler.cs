﻿using GameCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.ClientHandlers
{
    public class ListCharacterHandler : GameMessageHandler
    {
        protected override void OnHandleMessage(Dictionary<byte, object> parameters, string debugMessage, int returnCode)
        {
            if (returnCode == (short)ReturnCode.OK)
            {
                // Show the login screen since it was successful
                Debug.LogFormat("Character List - {0}", parameters[(byte)MessageParameterCode.Object]);
            }
            else
            {
                // Show the error dialog
                // ShowError(response.DebugMessage);
                Debug.LogFormat("{0}", debugMessage);
            }
        }
    }
}
