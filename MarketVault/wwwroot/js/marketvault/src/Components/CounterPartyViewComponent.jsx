class CounterPartyViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="counterPartyName">
                    {this.props.name}
                </p>
                <p className="counterPartyVATNumber">
                    {this.props.vatNumber}
                </p>
                <p className="counterPartyValueAddedTaxLawId">
                    {this.props.valueAddedTaxLawId}
                </p>
                <p className="counterPartyBankName">
                    {this.props.bankName}
                </p>
                <p className="counterPartyBankCode">
                    {this.props.bankCode}
                </p>
                <p className="counterPartyBankIBAN">
                    {this.props.bankIban}
                </p>
                <p className="counterPartyFirmName">
                    {this.props.firmName}
                </p>
            </div>
        );
    }
}