class FirmViewComponent extends React.Component {
    render() {
        return (
            <div>
                <p className="firmName">
                    {this.props.name}
                </p>
                <p className="firmPhoneNumber">
                    {this.props.phoneNumber}
                </p>
                <p className="firmEmail">
                    {this.props.email}
                </p>
                <p className="firmResponsiblePersonName">
                    {this.props.responsiblePersonName}
                </p>
                <p className="firmAddress">
                    {this.props.address}
                </p>
            </div>
        );
    }
}