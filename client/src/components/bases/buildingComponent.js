import { observer } from "mobx-react-lite";
import React from "react";

const BuildingComponent = (building) => {
    let data = building.building;

    const getColor = () => {
        switch(data.name) {
            case "Command Centre":
                return "#8affff";
            case "Guild Hub":
                return "#e88819";
            case "Barracks":
                return "#155866";
            case "Warroom":
                return "#297045";
            case "Navigational Unit":
                return "aqua";
            case "Radar":
                return "maroon";
            case "Medical Facility":
                return "#FF1111";
            case "Research Facility":
                return "#23a868";
            case "Tradepost":
                return "#932061";
            case "Market":
                return "#787872";
            case "Silos":
                return "#1f2553";
            case "Vaults":
                return "#625f15";
            case "Bunkers":
                return "#4b221f";
            case "Shield":
                return "#467489";
            default: 
            return "whitesmoke";
        }
    }

    return (
        <div style={{color: getColor()}} className="text-left">{data.name}</div>
    )
}

export default observer(BuildingComponent);