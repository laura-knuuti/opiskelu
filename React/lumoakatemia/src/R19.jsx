function NimiLista() 
{
    const nimet = ["Aada", "Bärtil", "Kalle", "Taavetti", "Eeva"];
    const lista = nimet.map(nimet =>
        <li key = {nimet}>{nimet}</li>);

        return (
        <ul>
            {lista}       
        </ul>
    );
}

export default NimiLista;