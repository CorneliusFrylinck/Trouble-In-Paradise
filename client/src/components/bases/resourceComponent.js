import { observer } from "mobx-react-lite";
import React from "react";
import { Link } from "react-router-dom";

const ResourceComponent = ({
    name, production, available
}) => {
    return (
        <>
            <Link to={"resource/"+name} className="resource-item">{name}: {available} ({production}/h)</Link>
        </>
    )
}

export default observer(ResourceComponent);