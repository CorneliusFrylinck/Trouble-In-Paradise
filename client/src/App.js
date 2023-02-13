import './App.css';
import { observer } from 'mobx-react-lite';
import { useEffect, useState } from 'react';
import { useStore } from './stores/store';
import BasePage from './components/bases/basePage';

function App() {
  const { basesStore } = useStore();
  const [base, setBase] = useState(null);
  
  useEffect(() => {
    const setStoreBase = async () => {
      basesStore.retrieveBase().then(res => {
        basesStore.base = res;
        setBase(res)
      })
    }
    setStoreBase();
  }, [])

  if (base === null || base === undefined) return (<div>loading...</div>)
  
  return (
    <div className="App">
      <BasePage base={base} />
    </div>
  );
}

export default observer(App);
