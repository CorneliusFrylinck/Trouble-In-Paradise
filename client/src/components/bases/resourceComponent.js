import { observer } from "mobx-react-lite";
import React from "react";
import { Link } from "react-router-dom";

const ResourceComponent = ({
    name, production, available, color
}) => {
    return (
        <>
            <Link to={"resource/"+name} style={{color: color}} className="resource-component">{name.replace('_', ' ')}: {available} ({production}/h)</Link>
        </>
    )
}

export default observer(ResourceComponent);