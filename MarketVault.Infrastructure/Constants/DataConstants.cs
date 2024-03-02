namespace MarketVault.Infrastructure.Constants
{
    public static class DataConstants
    {
        public static class ItemGroupConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }

        public static class BarcodeConstants
        {
            public const int ValueMinLength = 5;
            public const int ValueMaxLength = 25;
        }

        public static class MeasureConstants
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 6;
        }

        public static class ProductConstants
        {
            public const int NumberMinValue = 0;
            public const int NumberMaxValue = 9999;

            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int CashRegisterNameMinLength = 1;
            public const int CashRegisterNameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
        }

        public static class AddressConstants
        {
            public const int TownNameMinLength = 2;
            public const int TownNameMaxLength = 50;

            public const int StreetNameMinLength = 1;
            public const int StreetNameMaxLength = 100;

            public const int StreetNumberMinValue = 1;
            public const int StreetNumberMaxValue = 9999;
        }

        public static class BankConstants
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 100;
        }

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

        public static class CounterPartyConstants
        {
            public const int NumberMinValue = 0;

            public const int NameMinLength = 3;
            public const int NameMaxLength = 36;

            public const int VATNumberMinLength = 3;
            public const int VATNumberMaxLength = 24;

            public const int ValueAddedTaxLawIdMinLength = 2;
            public const int ValueAddedTaxLawIdMaxLength = 28;
        }

        public static class DocumentTypeConstants
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;
        }
    }
}
