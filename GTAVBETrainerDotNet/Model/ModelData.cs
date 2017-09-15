//////////////////////////////////////////////
//   BE Trainer.NET for Grand Theft Auto V
//             by BE.Tenner
//      Copyright (c) BE Group 2015-2017
//               Thanks to
//    ScriptHookV & ScriptHookVDotNet
//  Native Trainer & Enhanced Native Trainer
//////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVBETrainerDotNet.Model
{
    /// <summary>
    /// Model data
    /// </summary>
    public class ModelData
    {
        private string _name = null;
        private string _hash = null;

        /// <summary>
        /// Name of model
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Hash of mmodel
        /// </summary>
        public string Hash
        {
            get
            {
                return _hash;
            }
        }

        /// <summary>
        /// Creates a model data
        /// </summary>
        /// <param name="name">Name of model</param>
        /// <param name="hash">Hash of model</param>
        public ModelData(string name, string hash)
        {
            _name = name;
            _hash = hash;
        }
    }
}
