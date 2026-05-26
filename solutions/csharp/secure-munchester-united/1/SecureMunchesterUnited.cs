using System;

public class SecurityPassMaker
{
    public string GetDisplayName(TeamSupport support)
    {
        // TASK 1: Si NO es un miembro del Staff (ej. Manager, Chairman)
        if (!(support is Staff))
        {
            return "Too Important for a Security Pass";
        }

        // TASK 2: Si es ESTRICTAMENTE de la clase 'Security' base, 
        // se le concatena " Priority Personnel" para cumplir con el Assert exacto.
        if (support.GetType() == typeof(Security))
        {
            return $"{support.Title} Priority Personnel";
        }

        // TASK 3: Para el resto de las subclases de seguridad (Junior, Intern, Liaison)
        // y demás miembros de Staff (Physio, Coaches), devuelve su título normal.
        return support.Title;
    }
}

/**** Por favor, no alteres el código de abajo ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }