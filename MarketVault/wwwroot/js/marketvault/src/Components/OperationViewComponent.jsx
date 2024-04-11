class OperationViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p>
                    {this.props.dateMade}
                </p>
                <p>
                    {this.props.productsCount}
                </p>
                <p>
                    {this.props.counterParty}
                </p>
                <p>
                    {this.props.documentType}
                </p>
                <p>
                    {this.props.totalPurchasePriceWithoutVAT}
                </p>
                <p>
                    {this.props.totalPurchasePriceWithVAT}
                </p>
                <p>
                    {this.props.totalSalePriceWithoutVAT}
                </p>
                <p>
                    {this.props.totalSalePriceWithVAT}
                </p>
            </div>
        );
    }
}