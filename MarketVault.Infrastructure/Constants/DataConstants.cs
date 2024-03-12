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
            public const int NameMaxLength = 20;
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

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int CashRegisterNameMinLength = 3;
            public const int CashRegisterNameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
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

            public const int PhoneNumberLength = 20;

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
            public const int BankIBANMaxLength = 18;
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
        }
    }
}
