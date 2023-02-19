import { observer } from "mobx-react-lite";
import React from "react";
import { Link } from "react-router-dom";

const ResourceComponent = ({
    name, production, available, color, baseId
}) => {
    return (
        <>
            <Link to={"resource/"+baseId+"/"+name} style={{color: color}} className="resource-component">{name.replace('_', ' ')}: {Math.floor(available)} ({production}/hr)</Link>
        </>
    )
}

export default observer(ResourceComponent);