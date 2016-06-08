﻿using Nucleus.Coop;
using Nucleus.Gaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Games.Borderlands
{
    public class Borderlands2GenericInfo : GenericGameInfo
    {
        public override bool SupportsKeyboard
        {
            get { return true; }
        }
        public override Type[] Steps
        {
            get
            {
                return new Type[]
                {
                    typeof(PlayerCountControl),
                    typeof(PositionsForm),
                    typeof(PlayerOptions)
                };
            }
        }
        public override string ExecutableContext
        {
            get { return ""; }
        }
        public override string ExecutableName
        {
            get { return "borderlands2.exe"; }
        }

        public override string GameName
        {
            get { return "Borderlands 2"; }
        }

        public override Type HandlerType
        {
            get { return typeof(GenericGameHandler); }
        }

        public override int MaxPlayers
        {
            get { return 4; }
        }

        protected Dictionary<string, GameOption> options;
        public override Dictionary<string, GameOption> Options
        {
            get { return options; }
        }

        public Borderlands2GenericInfo()
        {
            options = new Dictionary<string, GameOption>();

            options.Add("keyboardPlayer", new GameOption("Keyboard Player", "The player that will be playing on keyboard and mouse", KeyboardPlayer.NoKeyboardPlayer));
            options.Add("saveid0", new GameOption("Save ID - Player 1", "Save ID to use for Player 1 (default 0)", 0));
            options.Add("saveid1", new GameOption("Save ID - Player 2", "Save ID to use for Player 2 (default 1)", 1));
            options.Add("saveid2", new GameOption("Save ID - Player 3", "Save ID to use for Player 3 (default 2)", 2));
            options.Add("saveid3", new GameOption("Save ID - Player 4", "Save ID to use for Player 4 (default 3)", 3));
        }

        /// <summary>
        /// Generated with http://www.random-guid.com/
        /// </summary>
        public override string GUID
        {
            get { return "720CE71B-FCBF-46C8-AC9D-C4B2BF3169E3"; }
        }

        public override int MaxPlayersOneMonitor
        {
            get { return 4; }
        }

        public override GenericGameSaveType SaveType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string SavePath
        {
            get { return @"&MyDocuments&\My Games\Borderlands 2\WillowGame\Config\WillowEngine.ini"; }
        }

        public override Dictionary<string, string> ModifySave
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "SystemSettings/WindowedFullscreen", "&IsFullscreen&" },
                    { "SystemSettings/ResX", "&Width&" },
                    { "SystemSettings/ResY", "&Height&" },
                    { "SystemSettings/Fullscreen", "False" },
                    { "Engine.Engine/bMuteAudioWhenNotInFocus", "False" },
                    { "Engine.Engine/bPauseOnLossOfFocus", "False" },
                    { "WillowGame.WillowGameEngine/bPauseLostFocusWindowed", "False" },
                    { "WillowGame.WillowGameEngine/bMuteAudioWhenNotInFocus", "False" },
                };
            }
        }

        public override string StartArguments
        {
            get { return "%if(&Options.Keyboard&){-AlwaysFocus -NoController -SaveDataId=&Id&}else{-AlwaysFocus -nostartupmovies -SaveDataId=&Id&}"; }
        }
    }
}