STDOUT.sync = true

@bulding_width, @bulding_height = gets.split(" ").collect {|x| x.to_i}
@max_turns_before_game_over = gets.to_i
@batman_position_X, @batman_position_Y = gets.split(" ").collect {|x| x.to_i}

# Coordinates of new window from min to max
min_X = 0
min_Y = 0
max_X = @bulding_width - 1
max_Y = @bulding_height - 1

loop do
  bomb_direction_from_current_location = gets.chomp # U, UR, R, DR, D, DL, L or UL

  if (bomb_direction_from_current_location.include? 'L')
    if bomb_direction_from_current_location.index('L') >= 0
      max_X = @batman_position_X - 1
    end
  elsif bomb_direction_from_current_location.include? 'R'
    if bomb_direction_from_current_location.index('R') >= 0
      min_X = @batman_position_X + 1
    end
  end

  if bomb_direction_from_current_location[0] == 'U'
    max_Y = @batman_position_Y - 1
  elsif bomb_direction_from_current_location[0] == 'D'
    min_Y = @batman_position_Y + 1
  end

  @batman_position_X = (min_X + max_X) / 2
  @batman_position_Y = (min_Y + max_Y) / 2

  puts (@batman_position_X.to_s + " " + @batman_position_Y.to_s)

end