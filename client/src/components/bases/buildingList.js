import { observer } from "mobx-react-lite";
import React from "react";
import "./base.css";
import BuildingComponent from "./buildingComponent";

const BuildingList = ({
    buildings
}) => {
    
    return (
        <>
            <h3 className="text-left">Buildings:</h3>
            <div className="building-list">
                {buildings.map((building, idx) => {
                    return (<BuildingComponent building={building} key={idx} />)
                })}
            </div>
        </>
    )
}

export default observer(BuildingList);