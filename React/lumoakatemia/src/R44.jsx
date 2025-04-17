import {useState, useEffect} from "react";

export default function Bitcoin() {
    const [prices, setPrices] = useState([]);

    useEffect(() => {
        fetch (`https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd,eur,gbp`)
        .then(response => response.json())
        .then((data) => setPrices (data.bitcoin));
    }, []);
    return (
        <div>
            <h3>Bitcoinin kurssi</h3>
            <ul>
            {Object.entries(prices).map (([currency, price]) => (
            <li key={currency}>
            {currency.toUpperCase()}: {price}
            </li>
        ))}
        </ul>
        </div>
);
}