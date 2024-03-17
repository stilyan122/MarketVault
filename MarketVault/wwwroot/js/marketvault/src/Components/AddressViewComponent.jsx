class AddressViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="addressTownName">
                    {this.props.townName}
                </p>
                <p className="addressStreetName">
                    {this.props.streetName}
                </p>
                <p className="addressStreetNumber">
                    {this.props.streetNumber}
                </p>
            </div>
        );
    }
}