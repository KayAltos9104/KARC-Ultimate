﻿using KARC.WitchEngine;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KARC.Objects
{
    class Wall : IObject
    {
        public int ImageId { get; set; }
        public Vector2 Pos { get; set; }
        public Vector2 Speed { get; set; }

        public void Move(Vector2 pos)
        {
            
        }

        public void Update()
        {

        }
    }
}