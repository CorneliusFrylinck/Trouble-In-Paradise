import { observer } from "mobx-react-lite";
import React from "react";
import ResourceList from "./resourceList";
import "./base.css";
import BuildingList from "./buildingList";

const BasePage = ({base}) => {
    
    return (
        <div className="base-page">
            <div>BasePage</div>
            <div className="list-container">
                <ResourceList resources={base.resources} />
            </div>
            <div className="list-container">
                <BuildingList buildings={base.resources} />
            </div>
        </div>
    )
}

export default observer(BasePage);