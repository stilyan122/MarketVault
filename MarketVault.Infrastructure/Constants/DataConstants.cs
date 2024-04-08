namespace MarketVault.Infrastructure.Constants
{
    /// <summary>
    /// Static class for data constants
    /// </summary>
    public static class DataConstants
    {
        /// <summary>
        /// Constants for item group entity
        /// </summary>
        public static class ItemGroupConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }

        /// <summary>
        /// Constants for barcode entity
        /// </summary>
        public static class BarcodeConstants
        {
            public const int ValueMinLength = 5;
            public const int ValueMaxLength = 25;
        }

        /// <summary>
        /// Constants for measure entity
        /// </summary>
        public static class MeasureConstants
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 6;
        }

        /// <summary>
        /// Constants for product entity
        /// </summary>
        public static class ProductConstants
        {
            public const int NumberMinValue = 0;
            public const int NumberMaxValue = 9999;

            public const string NumberMinPriceValue = "0";
            public const string NumberMaxPriceValue = "9999";

            public const int NumberMinLength = 2;
            public const int NumberMaxLength = 10;

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int CashRegisterNameMinLength = 3;
            public const int CashRegisterNameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;

            public const string PriceFormat = @"^\d+(\.\d+)?(,\d+)?$";
        }
        
        /// <summary>
        /// Constants for address entity
        /// </summary>
        public static class AddressConstants
        {
            public const int TownNameMinLength = 2;
            public const int TownNameMaxLength = 50;

            public const int StreetNameMinLength = 1;
            public const int StreetNameMaxLength = 100;

            public const int StreetNumberMinValue = 1;
            public const int StreetNumberMaxValue = 9999;
        }

        /// <summary>
        /// Constants for bank entity
        /// </summary>
        public static class BankConstants
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 100;
        }

        /// <summary>
        /// Constants for firm entity
        /// </summary>
        public static class FirmConstants
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 30;

            public const int EmailMinLength = 3;
            public const int EmailMaxLength = 320;

            public const int ResponsiblePersonNameMinLength = 3;
            public const int ResponsiblePersonNameMaxLength = 320;
        }

        /// <summary>
        /// Constants for counter party entity
        /// </summary>
        public static class CounterPartyConstants
        {
            public const int NumberMinValue = 0;

            public const int NameMinLength = 3;
            public const int NameMaxLength = 36;

            public const int VATNumberMinLength = 3;
            public const int VATNumberMaxLength = 24;

            public const int ValueAddedTaxLawIdMinLength = 2;
            public const int ValueAddedTaxLawIdMaxLength = 28;

            public const int BankCodeMinLength = 6;
            public const int BankCodeMaxLength = 12;

            public const int BankIBANMinLength = 8;
            public const int BankIBANMaxLength = 26;
        }

        /// <summary>
        /// Constants for document type entity
        /// </summary>
        public static class DocumentTypeConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;
        }

        /// <summary>
        /// Constants for application user entity
        /// </summary>
        public static class UserConstants
        {
            public const int FirstNameMaxLength = 30;
            public const int FirstNameMinLength = 1;

            public const int LastNameMaxLength = 30;
            public const int LastNameMinLength = 1;
        }

        /// <summary>
        /// Constants for exception messages
        /// </summary>
        public static class ExceptionMessagesConstants
        {
            public const string ProductNameRequiredExceptionMessage
                = "Field for name is required!";
            public const string ProductNameLengthExceptionMessage
                = "Length of field name must be between {2} " +
                "and {1} characters long!";

            public const string ProductCashRegisterNameRequiredExceptionMessage
                = "Field for cash register name is required!";
            public const string ProductCashRegisterNameLengthExceptionMessage
                = "Length of field cash register name must be between {2} " +
                "and {1} characters long!";

            public const string ProductSalePriceRequiredExceptionMessage
                = "Field for sale price is required!";
            public const string ProductSalePriceRangeExceptionMessage
                = "Length of field sale price must be between {2} " +
                "and {1} characters long!";

            public const string ProductPurchasePriceRequiredExceptionMessage
               = "Field for purchase price is required!";
            public const string ProductPurchasePriceRangeExceptionMessage
                = "Length of field purchase price must be between {2} " +
                "and {1} characters long!";

            public const string ProductDescriptionRequiredExceptionMessage
                = "Field for description is required!";
            public const string ProductDescriptionLengthExceptionMessage
                = "Length of field description must be between {2} " +
                "and {1} characters long!";

            public const string ProductItemGroupRequiredExceptionMessage
               = "Field for item group is required!";

            public const string ProductMeasureRequiredExceptionMessage
               = "Field for measure is required!";

            public const string ProductPurchasePriceFormatExceptioMessage
               = "Invalid purchase price format.";

            public const string ProductSalePriceFormatExceptioMessage
               = "Invalid sale price format.";

            public const string ProductPurchasePriceLengthExceptioMessage
               = "Invalid length of field purchase price! Must be between {2} and {1}.";

            public const string ProductSalePriceLengthExceptioMessage
               = "Invalid length of field sale price! Must be between {2} and {1}.";


            public const string CounterPartyNameRequiredExceptionMessage
                = "Field for counter party name is required!";
            public const string CounterPartyNameLengthExceptionMessage
                = "Length of field counter party name must be between {2} " +
                "and {1} characters long!";

            public const string CounterPartyVATNumberRequiredExceptionMessage
                = "Field for counter party VAT number is required!";
            public const string CounterPartyVATNumberLengthExceptionMessage
                = "Length of field counter party VAT number must be between {2} " +
                "and {1} characters long!";

            public const string CounterPartyValueAddedTaxLawIdRequiredExceptionMessage
                = "Field for counter party value added tax law id is required!";
            public const string CounterPartyValueAddedTaxLawIdLengthExceptionMessage
                = "Length of field counter party value added tax law id " +
                "must be between {2} " +
                "and {1} characters long!";

            public const string CounterPartyBankRequiredExceptionMessage
                = "Field for bank is required!";

            public const string CounterPartyBankCodeRequiredExceptionMessage
                = "Field for counter party bank code is required!";
            public const string CounterPartyBankCodeLengthExceptionMessage
                = "Length of field counter party bank code must be between {2} " +
                "and {1} characters long!";

            public const string CounterPartyBankIBANRequiredExceptionMessage
                = "Field for counter party bank IBAN is required!";
            public const string CounterPartyBankIBANLengthExceptionMessage
                = "Length of field counter party bank IBAN must be between {2} " +
                "and {1} characters long!";

            public const string CounterPartyFirmRequiredExceptionMessage
                = "Field for firm is required!";





            public const string FirmNameRequiredExceptionMessage
               = "Field for firm name is required!";
            public const string FirmNameLengthExceptionMessage
                = "Length of field firm name must be between {2} " +
                "and {1} characters long!";

            public const string FirmPhoneRequiredExceptionMessage
               = "Field for firm name is required!";
            public const string FirmPhoneRegexExceptionMessage
                = "Field phone must be in such standart: [0894564314] or " +
                "[+359892345215]";

            public const string FirmEmailRequiredExceptionMessage
              = "Field for firm email is required!";
            public const string FirmEmailLengthExceptionMessage
                = "Length of field firm email must be between {2} " +
                "and {1} characters long!";
            public const string FirmEmailRegexExceptionMessage
                = "Field email must be in such standard: [email@domain.extension]";

            public const string FirmResponsiblePersonRequiredExceptionMessage
             = "Field for firm responsible person is required!";
            public const string FirmResponsiblePersonLengthExceptionMessage
                = "Length of field firm responsible person must be between {2} " +
                "and {1} characters long!";

            public const string FirmAddressRequiredExceptionMessage
               = "Field for firm address is required!";





            public const string BankNameRequiredExceptionMessage
               = "Field for bank name is required!";
            public const string BankNameLengthExceptionMessage
                = "Length of field bank name must be between {2} " +
                "and {1} characters long!";

            public const string BankAddressRequiredExceptionMessage
               = "Field for bank address is required!";





            public const string ItemGroupNameRequiredExceptionMessage
              = "Field for item group name is required!";
            public const string ItemGroupNameLengthExceptionMessage
                = "Length of field item group name must be between {2} " +
                "and {1} characters long!";





            public const string AddressTownNameRequiredExceptionMessage
               = "Field for address town name is required!";
            public const string AddressTownNameLengthExceptionMessage
                = "Length of field address town name must be between {2} " +
                "and {1} characters long!";

            public const string AddressStreetNameRequiredExceptionMessage
               = "Field for address street name is required!";
            public const string AddressStreetNameLengthExceptionMessage
                = "Length of field address street name must be between {2} " +
                "and {1} characters long!";

            public const string AddressStreetNumberRequiredExceptionMessage
               = "Field for address street number is required!";
            public const string AddressStreetNumberLengthExceptionMessage
                = "Length of field address street number must be between {2} " +
                "and {1} characters long!";





            public const string FirstNameRequiredExceptionMessage
               = "Field for first name is required!";
            public const string FirstNameLengthExceptionMessage
                = "Length of field first name must be between {2} " +
                "and {1} characters long!";

            public const string LastNameRequiredExceptionMessage
               = "Field for last name is required!";
            public const string LastNameLengthExceptionMessage
                = "Length of field last name must be between {2} " +
                "and {1} characters long!";
        }

        /// <summary>
        /// Constants for roles
        /// </summary>
        public static class RoleConstants
        {
            public const string WorkerAndAdminRoles = "Worker,Admin";
            public const string AdminRole = "Admin";
        }
    }
}
