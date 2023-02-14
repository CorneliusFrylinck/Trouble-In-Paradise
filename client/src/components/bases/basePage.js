import { observer } from "mobx-react-lite";
import React from "react";
import ResourceList from "./resourceList";
import "./base.css";

const BasePage = ({base}) => {
    
    return (
        <div className="base-page">
            <div>BasePage</div>
            <div className="list-container">
                <ResourceList resources={base.resources} />
            </div>
        </div>
    )
}

export default observer(BasePage);