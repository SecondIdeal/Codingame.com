STDOUT.sync = true

@lenght_of_road     = gets.to_i
@lenght_of_gap      = gets.to_i
@lenght_of_platform = gets.to_i

loop do
  @motorbike_speed    = gets.to_i
  @motorbike_position = gets.to_i

  if (@motorbike_position > @lenght_of_road or @motorbike_speed > @lenght_of_gap + 1)
    puts "SLOW"
  elsif (@motorbike_speed < @lenght_of_gap + 1)
    puts "SPEED"
  elsif (@motorbike_position == @lenght_of_road - 1)
    puts "JUMP"
  else
    puts "WAIT"
  end
end