extends Button

export(String) var scene_to_load : String

func _on_Button_pressed():
	get_tree().change_scene(scene_to_load)
