import { observer } from "mobx-react-lite";
import React from "react";
import ResourceList from "./resourceList";

const BasePage = ({base}) => {
    
    return (
        <>
            <div>BasePage</div>
            <ResourceList resources={base.resources} />
        </>
    )
}

export default observer(BasePage);