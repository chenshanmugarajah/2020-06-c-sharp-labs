import React from 'react';

const ChildComponent = (props) => {

    return (
        <div>
            <button onClick={ () => props.incrementLikeCount() }>Child click me</button>
        </div>
    )
}

export default ChildComponent