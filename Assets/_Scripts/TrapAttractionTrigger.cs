// Nuovo file: TrapAttractionTrigger.cs

using UnityEngine;

public class TrapAttractionTrigger : MonoBehaviour
{
    // Riferimento allo script Trap sul GameObject genitore
    public Trap parentTrap;

    private void OnTriggerEnter(Collider other)
    {
        // Se non � stato assegnato il riferimento, non fare nulla
        if (parentTrap == null)
        {
            Debug.LogWarning("TrapAttractionTrigger: parentTrap non assegnato!", this);
            return;
        }

        // Chiamiamo il metodo pubblico sullo script Trap del genitore
        // Passiamo il collider del pirata che � entrato nel trigger
        parentTrap.OnPirateEnterAttractionTrigger(other);
    }
}