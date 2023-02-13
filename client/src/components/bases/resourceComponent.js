import { observer } from "mobx-react-lite";
import React from "react";

const ResourceComponent = ({
    name, production, available
}) => {
    return (
        <>
            <div>{name}: {available} ({production}/h)</div>
        </>
    )
}

export default observer(ResourceComponent);