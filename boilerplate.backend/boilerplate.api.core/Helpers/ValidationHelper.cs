﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boilerplate.api.core.Helpers
{
    public static class ValidationHelper
    {
        public static class MusicLabel
        {
            public const int NameMaxLength = 50;
        }

        public static class Musician
        {
            public const int NameMaxLength = 50;
        }

        public static class Platform
        {
            public const int NameMaxLength = 50;
        }

        public static class Contact
        {
            public const int NameMaxLength = 50;
            public const int TitleMaxLength = 50;
            public const int CompanyMaxLength = 150;
            public const int EmailMaxLength = 250;
            public const int FiftyElementsLength = 50;
        }
    }
}
