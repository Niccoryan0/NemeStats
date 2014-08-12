﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Exceptions
{
    public class UnauthorizedEntityAccessException : Exception
    {
        internal const string EXCEPTION_MESSAGE_FORMAT = "User with Id '{0}' does not have access to entity with Id '{1}";

        private string userId;
        private object entityId;

        public UnauthorizedEntityAccessException(string userId, object entityId)
        {
            this.userId = userId;
            this.entityId = entityId;
        }

        public override string Message
        {
            get
            {
                return string.Format(EXCEPTION_MESSAGE_FORMAT, userId, entityId);
            }
        }
    }
}