class BankViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="bankName">
                    {this.props.name.replace('&amp;', '&')}
                </p>
                <p className="bankAddress">
                    {this.props.address}
                </p>
            </div>
        );
    }
}