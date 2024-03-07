class CommentBox extends React.Component {
    render() {
        return React.createElement(
            'div',
            { className: 'commentBox' },
            'Hello, world!' + this.props.name,
        );
    }
}