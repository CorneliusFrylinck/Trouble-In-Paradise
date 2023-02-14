import { observer } from "mobx-react-lite";
import React from "react";
import "./base.css";

const BuildingList = ({
    buildings
}) => {

    return (
        <>
            <h3 className="text-left">Buildings:</h3>
            <div className="building-list">
            </div>
        </>
    )
}

export default observer(BuildingList);