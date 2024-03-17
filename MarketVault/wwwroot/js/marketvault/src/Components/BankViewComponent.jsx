class BankViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="bankName">
                    {this.props.name}
                </p>
                <p className="bankAddress">
                    {this.props.address}
                </p>
            </div>
        );
    }
}