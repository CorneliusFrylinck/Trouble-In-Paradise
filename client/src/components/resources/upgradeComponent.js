import { observer } from "mobx-react-lite";
import React, { useState } from "react";

const UpgradeComponent = ({
    UpgradeHandler, building
}) => {
    const [upgrading, setUpgrading] = useState(false);
    const UpgradeBuilding = async () => {
        setUpgrading(true);
        await UpgradeHandler();
    }
    return (
        <>
            <h4 style={{padding: 0, margin: 0}}>Next Level:</h4>
            <div>Upgrade Time: {building.upgradeDetails.upgradeTimeInSeconds}s</div>
            <div>Upgraded Production: {building.upgradeDetails.productionAfterUpgrade}/hr</div>
            <div className="upgrade-costs">Upgrade Costs: 
                <div>
                    <span className="metal-color">{building.upgradeDetails.metalCost} M</span>, &nbsp;
                    <span className="cement-color">{building.upgradeDetails.cementCost} C</span>, &nbsp;
                    <span className="food-color">{building.upgradeDetails.foodCost} F</span>, &nbsp;
                    <span className="lumber-color">{building.upgradeDetails.lumberCost} L</span>, &nbsp;
                    <span className="water-color">{building.upgradeDetails.waterCost} W</span>, &nbsp;
                    <span className="oxygen-color">{building.upgradeDetails.oxygenCost} O</span>, &nbsp;
                    <span className="blue-crystal-color">{building.upgradeDetails.blue_CrystalCost} C</span>, &nbsp;
                    <span className="red-crystal-color">{building.upgradeDetails.red_CrystalCost} C</span>
                </div>
            </div>
            <button onClick={() => UpgradeBuilding()} className="upgrade-btn" disabled={upgrading}>Upgrade</button>
        </>
    )
}

export default observer(UpgradeComponent);