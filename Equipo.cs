namespace diccionarios_csharp;
public class Equipo{
    private string ? nombre;
    private string ? jugadores;
    private string ? panelTecnico;
    private string ? panelMedico;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Jugadores { get => jugadores; set => jugadores = value; }
    public string? PanelTecnico { get => panelTecnico; set => panelTecnico = value; }
    public string? PanelMedico { get => panelMedico; set => panelMedico = value; }

    public Equipo(){

    }
    public Equipo(String nombre, string jugadores, string panelTecnico, string panelMedico){
        this.Nombre = nombre;
        this.Jugadores = jugadores;
        this.PanelTecnico = panelTecnico;
        this.PanelMedico = panelMedico;
    }
}