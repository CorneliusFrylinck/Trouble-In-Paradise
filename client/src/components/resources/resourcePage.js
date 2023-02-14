import { observer } from "mobx-react-lite";
import React from "react";
import { useParams } from "react-router-dom";

const ResourcePage = () => {
    let { name } = useParams();
    return (
        <div>{name}</div>
    )
}

export default observer(ResourcePage);