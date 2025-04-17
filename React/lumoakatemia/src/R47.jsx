import {useState, useEffect} from "react";

export default function Saatiedot() {
    const Weather = ({city}) => {
    const [weather, setWeather] = useState(null);

    useEffect(() => {
        fetch (`https://api.openweathermap.org/data/2.5/weather?q=${city}&appid=80ca1084deaa96ffce2b787495182428`)
        .then(response => response.json())
        .then(data => setWeather(data.main));
    }, [city]);
    return weather ? <p>{city}: {weather.temp}°C</p> : <p>Ladataan...</p>;
    };
    return (
        <Weather city = "Helsinki"/>
    )
}