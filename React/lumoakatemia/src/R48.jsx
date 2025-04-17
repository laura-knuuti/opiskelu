import {useState, useEffect} from "react";

export default function ChuckNorris() {
    const [jokes, setJokes] = useState([]);

    useEffect(() => {
        fetch ('https://api.chucknorris.io/jokes/random')
        .then((response) => response.json())
        .then((data) =>
            setJokes([data]));
    }, []);
    return (
        <div>
            <h3>Päivän Chuck Norris:</h3>
            <ul>
            {jokes.map((joke) => (
            <li key={joke.id}>{joke.value}</li>
        ))}
        </ul>
        </div>
);
}