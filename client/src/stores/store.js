import BasesStore from "./basesStore";
import { createContext, useContext } from "react";

export const store = {
    basesStore: new BasesStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}