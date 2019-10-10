// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Projet_UE4_BachelorEditorTarget : TargetRules
{
	public Projet_UE4_BachelorEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Projet_UE4_Bachelor" } );
	}
}
