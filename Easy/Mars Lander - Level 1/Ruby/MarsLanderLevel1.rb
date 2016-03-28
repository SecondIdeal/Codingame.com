STDOUT.sync = true

@number_of_surface_points = gets.to_i # used to draw the surface of Mars
@number_of_surface_points.times do
  surface_coordinate_X, surface_coordinate_Y  = gets.split(" ").collect {|x| x.to_i} # 0 to 6999 and  0 to 2999
end

loop do
  # in meters, in meters, in m/s, can be negative, in m/s, can be negative, in liters, in degrees (-90 to 90), 0 to 4
  lander_coordinate_X, lander_coordinate_Y, horizontal_speed, vertical_speed, fuel_remainig, rotation_angle, thrust_power  = gets.split(" ").collect {|x| x.to_i}
  puts "0 " + (vertical_speed.abs > 39 ? "4" : "0")
end