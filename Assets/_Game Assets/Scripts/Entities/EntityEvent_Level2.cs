using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntityEvent_Level2 : EntityEvent
{
    public override void EventOnLoadLevel()
    {
        base.EventOnLoadLevel();

        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.WaitInput)));
        um.AddUIAction(() => { um.AddTutorial(new Tutorial(TutorialType.None, LocalizationManager.TUTORIAL_UBIVISION_TOPFLOOR), 5.0f); um.NextAction(); });
    }

    public void GuestLaptopEvent()
    {
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.AfterInput)));
        um.AddUIAction(() => { AddBasicStatusEffectOnStartingEvent(); um.NextAction(); });
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.WaitInput)));
        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_GUEST))));
        um.AddUIAction(() => { RemoveBasicStatusEffectOnFinishEvent(); um.NextAction(); });
    }

    [SerializeField] CutsceneCamera m_elevatorEvent_Camera;
    public void ElevatorEvent(EntityCharacterNPC2D1BitSwitch doorSwitch)
    {
        m_elevatorEvent_Camera.UseCamera();
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.AfterInput)));
        um.AddUIAction(() => { AddBasicStatusEffectOnStartingEvent(); um.NextAction(); });
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.WaitInput)));
        um.AddUIAction(() => { doorSwitch.SetExpression(Expression_2D1Bit.Hello); um.NextAction(); });
        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_ELEFATAA, LocalizationManager.UV2_ELEVATOR_0, doorSwitch.voicePack))));
        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_ELEFATAA, LocalizationManager.UV2_ELEVATOR_1, doorSwitch.voicePack),
            new DialogueChoice[2] {
                new DialogueChoice(LocalizationManager.UV2_ELEVATOR_1_1, () => {
                    um.AddUIAction(() => { doorSwitch.SetExpression(Expression_2D1Bit.ThumbUp); um.NextAction(); });
                    um.AddUIAction(() => { doorSwitch.UseSwitch(); um.NextAction(); });
                    um.AddUIAction(() => StartCoroutine(um.DelayNextAction(1.0f)));
                    um.AddUIAction(() => StartCoroutine(um.AnimateTransition()));
                    um.AddUIAction(() => _TeleportPlayerToScene(GlobalGameManager.Instance.databaseManager.sceneLevels[2], true, 6));
                }),
                new DialogueChoice(LocalizationManager.UV2_ELEVATOR_1_2, () => {
                    um.AddUIAction(() => { doorSwitch.SetExpression(Expression_2D1Bit.None); um.NextAction(); });
                    um.AddUIAction(() => { RemoveBasicStatusEffectOnFinishEvent(); m_elevatorEvent_Camera.ReleaseCamera(); um.NextAction(); });
                }),
            })));
    }

    [SerializeField] CutsceneCamera m_talkEvent_Camera;
    public void TalkEvent(EntityCharacterNPC2DHumanoidBobaKotakLaptop bobaKotak)
    {
        m_talkEvent_Camera.UseCamera(0);
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.AfterInput)));
        um.AddUIAction(() => { AddBasicStatusEffectOnStartingEvent(); um.NextAction(); });
        um.AddUIAction(() => StartCoroutine(um.DelayUntilPhaseInput(PhaseEnum.WaitInput)));
        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK, bobaKotak.voicePack),
        new DialogueChoice[3] {
                    new DialogueChoice(LocalizationManager.UV2_TALK_CHOICES_1, () => {
                        um.AddUIAction(() => { m_talkEvent_Camera.UseCamera(1); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK_0_0))));
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", "..."))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK_0_1),
                            new DialogueChoice[4]
                            {
                                new DialogueChoice("(Annoyed)", () => player.animator.SetInteger("expression", 1)),
                                new DialogueChoice("(Smirk)", () => player.animator.SetInteger("expression", 3)),
                                new DialogueChoice("(Surprised)", () => player.animator.SetInteger("expression", 4)),
                                new DialogueChoice("...", () => player.animator.SetInteger("expression", 0)),
                            }
                            )));
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => { player.animator.SetInteger("expression", 0); um.NextAction(); });
                        um.AddUIAction(() => { RemoveBasicStatusEffectOnFinishEvent(); m_talkEvent_Camera.ReleaseCamera(); um.NextAction(); });
                    }),
                    new DialogueChoice(LocalizationManager.UV2_TALK_CHOICES_2, () => {
                        um.AddUIAction(() => { m_talkEvent_Camera.UseCamera(1); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK_1_0))));
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => { bobaKotak.GetComponent<AudioSource>().Play(); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_1))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_2))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_3))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_4))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_5))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_6))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_7))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_8))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_9))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_10))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_11))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_12))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_13))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_14))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_15))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_16))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_17))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_18))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, "Hmm..."))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOBAKOTAK, LocalizationManager.UV2_TALK_1_19))));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue(LocalizationManager.CHARACTER_BOARDDIRECTORS, LocalizationManager.UV2_TALK_1_20))));
                        um.AddUIAction(() => { bobaKotak.GetComponent<AudioSource>().Stop(); um.NextAction(); });

                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", "..."),
                            new DialogueChoice[4]
                            {
                                new DialogueChoice("(Annoyed)", () => player.animator.SetInteger("expression", 1)),
                                new DialogueChoice("(Smirk)", () => player.animator.SetInteger("expression", 3)),
                                new DialogueChoice("(Surprised)", () => player.animator.SetInteger("expression", 4)),
                                new DialogueChoice("...", () => player.animator.SetInteger("expression", 0)),
                            }
                            )));

                        string key = ProfileManager.PLAYERPREFS_HAVEPASSWORD + "-" + SceneManager.GetActiveScene().name + "-1";
                        um.AddUIAction(() => { PlayerPrefs.SetString(key, true.ToString()); um.NextAction(); });
                        
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => { player.animator.SetInteger("expression", 0); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", "..."))));
                        um.AddUIAction(() => { player.animator.SetInteger("expression", 3); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK_1_21))));
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => { player.animator.SetInteger("expression", 0); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", LocalizationManager.UV2_TALK_1_22))));
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(3.0f)));
                        um.AddUIAction(() => { player.animator.SetInteger("expression", 4); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AddDialogue(new Dialogue("", "!"))));
                        um.AddUIAction(() => { em.triggerCheckpoints[1].teleportArea.gameObject.SetActive(true); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.AnimateTransition("flashbang")));
                        um.AddUIAction(() => { player.animator.gameObject.SetActive(false); um.NextAction(); });
                        um.AddUIAction(() => StartCoroutine(um.DelayNextAction(4.0f)));
                        um.AddUIAction(() => StartCoroutine(um.AnimateTransition()));
                        um.AddUIAction(() => SceneManager.LoadScene("Void World"));
                    }),
                    new DialogueChoice(LocalizationManager.UV2_TALK_CHOICES_3, () => {
                        um.AddUIAction(() => { RemoveBasicStatusEffectOnFinishEvent(); m_talkEvent_Camera.ReleaseCamera(); um.NextAction(); });
                    }),
        })));
    }

}
