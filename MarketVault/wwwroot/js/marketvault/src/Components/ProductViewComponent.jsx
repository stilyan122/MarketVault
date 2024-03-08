class ProductViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="productName">
                    {this.props.name}
                </p>
                <p className="productCashRegisterName">
                    {this.props.cashRegisterName}
                </p>
                <p className="productQuantity">
                    {this.props.quantity}
                </p>
                <p className="productItemGroup">
                    {this.props.itemGroup}
                </p>
                <p className="productSalePrice">
                    {this.props.salePrice}
                </p>
                <p className="productPurchasePrice">
                    {this.props.purchasePrice}
                </p>
                <p className="productCodeForScales">
                    {this.props.codeForScales}
                </p>
                <p className="productDateAdded">
                    {this.props.dateAdded}
                </p>
                <p className="productDateModified">
                    {this.props.dateModified}
                </p>
                <p className="productMeasure">
                    {this.props.measure}
                </p>
            </div>
        );
    }
}