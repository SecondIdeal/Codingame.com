STDOUT.sync = true

@light_x, @light_y, @initial_tx, @initial_ty = gets.split(" ").collect {|x| x.to_i}

loop do
  if @light_x > @initial_tx
      @initial_tx += 1
      @direction_X = "E"
  elsif @light_x < @initial_tx
      @initial_tx -= 1
      @direction_X = "W"
  else
      @direction_X = ""
  end

  if @light_y > @initial_ty
      @initial_ty += 1
      @direction_Y = "S"
  elsif @light_y < @initial_ty
      @initial_ty -= 1
      @direction_Y = "N"
  else
      @direction_Y = ""
  end

  puts (@direction_Y + @direction_X)
end