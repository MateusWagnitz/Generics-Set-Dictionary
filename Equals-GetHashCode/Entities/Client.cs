﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Equals_GetHashCode.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //comparando clientes
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
