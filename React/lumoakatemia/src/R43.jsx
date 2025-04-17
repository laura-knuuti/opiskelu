import {useState, useEffect} from "react";

export default function GitHubRepos() {
    const [repos, setRepos] = useState([]);
    const username = "octocat";

    useEffect(() => {
        fetch (`https://api.github.com/users/${username}/repos`)
        .then(response => response.json())
        .then(data => {
            setRepos(data);
        });
    }, []);
    return (
        <div>
            <h3>{username} repositiot:</h3>
            <ul>
            {repos.map(repo => (
            <li key={repo.id}>
            <a href={repo.html_url} target="_blank" rel="noopener noreferrer">
                {repo.name}
            </a> 
            </li>
        ))}
        </ul>
        </div>
);
}