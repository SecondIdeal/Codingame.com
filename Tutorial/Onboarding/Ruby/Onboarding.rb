STDOUT.sync = true

loop do
  $enemy_1_name = gets.chomp
  $enemy_1_distance = gets.to_i
  $enemy_2_name = gets.chomp
  $enemy_2_distance = gets.to_i

  puts (if $enemy_1_distance < $enemy_2_distance then $enemy_1_name else $enemy_2_name end)
end