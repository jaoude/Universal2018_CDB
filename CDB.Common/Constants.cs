﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CDB.Common
{
    public static class Constants
    {
        public const int CLIENT_ID_CHAR_LENGTH = 12;
        public const int COMPANY_NAME_CHAR_LENGTH = 100;
        public const int BANK_NAME_CHAR_LENGHT = 100;
        public const int FINANCIAL_AUDITOR_NAME_CHAR_LENGHT = 100;
        public const int AUTHORIZED_SIGNATURE_CHAR_LENGHT = 100;
        public const int SHAREHOLDERS_NAME_CHAR_LENGHT = 100;
        public const int REGISTRATION_PLACE_CHAR_LENGTH = 100;

        public const string DISPLAY_NAME_SEPARATOR = " / ";
        public const string DISPLAY_COMPANY_NAME_ARABIC = "Company name in arabic";
        public const string DISPLAY_COMPANY_NAME_ARABIC_AR = "إسم الشركة باللغة العربية";

        public const string DISPLAY_COMPANY_TYPE = "Company TYPE";
        public const string DISPLAY_COMPANY_TYPE_AR = "نوع الشركة";


        public const string ADMIN_ROLE_NAME = "Administrator";
        public const string MANAGER_ROLE_NAME = "Manager";
        public const string MEMBER_ROLE_NAME = "Member";
        public const string ADMIN_USER_PASSWORD = "Admin_123";
        public const string ADMIN_USER_EMAIL = "admin@admin.com";


    }
}

