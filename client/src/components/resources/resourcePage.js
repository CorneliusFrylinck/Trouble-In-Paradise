import { observer } from "mobx-react-lite";
import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { useStore } from "../../stores/store";
import "./buildings.css";
import UpgradeComponent from "./upgradeComponent";

const ResourcePage = () => {
    let { baseId, name } = useParams();
    const [pageProps, setPageProps] = useState(undefined);
    const { buildingsStore } = useStore();

    useEffect(() => {
        GetPageProps();
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])

    const GetPageProps = async() => {
        buildingsStore.getResourceBuildings(baseId, name).then((p) => {
            setPageProps(p);
        });
    }

    const UpgradeHandler = async() => {
        //
    }

    if (pageProps === undefined) {
        return (
            <div>Loading...</div>
        )
    }

    return (
        <>
            <h2>{name} {pageProps.resourceBuildings[0].buildingReference}s</h2>
            <h4>{pageProps.resourceBuildings[0].description}</h4>
            <div className="resource-buildings">
                {pageProps.resourceBuildings.map((b, idx) => {
                    return (
                        <div className="resource-building" key={idx}>
                            <h3 style={{marginBottom: "0.2rem"}}>{b.buildingReference} {idx+1}</h3>
                            <div>Level: {b.level}</div>
                            <div>Production: {b.production}/hr</div>
                            <UpgradeComponent building={b} UpgradeHandler={UpgradeHandler} />
                        </div>
                    );
                })}
            </div>
        </>
    )
}

export default observer(ResourcePage);