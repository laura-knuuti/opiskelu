function MapNumerot() 
{
    const numerot = [1, 2, 3, 4, 5];
    const lista = numerot.map(numerot =>
        <li key = {numerot}>{numerot}</li>);

        return (
        <ul>
            {lista}       
        </ul>
    );
}

/*
    const sisalto = document.getElementById('root');
    const root = createRoot(sisalto);
    root.render(<div>{<MapNumerot/>}</div>);*/

    export default MapNumerot;
