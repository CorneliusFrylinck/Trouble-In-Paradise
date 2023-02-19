import BasesStore from "./basesStore";
import BuildingsStore from "./buildingsStore";
import { createContext, useContext } from "react";

export const store = {
    basesStore: new BasesStore(),
    buildingsStore: new BuildingsStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}