using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManagerNPC : EntityManager
{
    public override void SetupEntitiesOnLevelStart()
    {
        base.SetupEntitiesOnLevelStart();
        _AssignNPCsToGrid();
        _SetNPCsIsActive();
    }

    public List<EntityCharacterNPC> GetNPCPlayableList()
    {
        var playableNPCs = new List<EntityCharacterNPC>();
        for(int i=0; i<entities.Count; i++)
        {
            if (entities[i].isUpdateAble)
                playableNPCs.Add(entities[i] as EntityCharacterNPC);
        }

        return playableNPCs;
    }

    private void _AssignNPCsToGrid()
    {
        foreach(EntityCharacterNPC npc in entities)
        {
            npc.AssignToLevelGrid();
        }
    }

    private void _SetNPCsIsActive()
    {
        foreach(EntityCharacterNPC npc in entities)
        {
            npc.SetIsUpdateAble(true);
        }
    }
}
