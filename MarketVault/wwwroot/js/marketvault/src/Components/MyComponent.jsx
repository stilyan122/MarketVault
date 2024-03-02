// Example React component with view model passed as props
import React from 'react';

class MyComponent extends React.Component {
    public render() {
        const { viewModel } = {
            viewModel: {
                title: 'pesho',
                description: 'eartewr'
            }
        };

        // Access view model passed as props
        return (
            <div>
                <h1>{viewModel.title}</h1>
                <p>{viewModel.description}</p>
            </div>
        );
    }
}

export default MyComponent;