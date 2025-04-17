import {useState, useEffect} from "react";

export default function ApiUsers() {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        fetch ('https://randomuser.me/api/?results=5')
        .then(response => response.json())
        .then(data => {
            setUsers(data.results);
        });
        }, []);
        return (
            <div>
                <h3>Käyttäjät</h3>
                <ul>
                {users.map(user => (
                <li key={user.login.uuid}>
                <img src = {user.picture.medium} alt = {user.name.first} />
                <p>{user.name.first} {user.name.last}</p>
                <p>{user.email}</p>
                </li>
            ))}
            </ul>
            </div>
    );
}
