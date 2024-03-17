class ItemGroupViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="itemGroupName">
                    {this.props.name}
                </p>
                <p className="itemGroupProductsCount">
                    {this.props.productsCount}
                </p>
            </div>
        );
    }
}