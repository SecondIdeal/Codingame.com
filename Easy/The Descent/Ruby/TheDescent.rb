STDOUT.sync = true

loop do

  mountains_heights = []

  8.times do
    mountains_heights << gets.to_i
  end

  puts mountains_heights.index (mountains_heights.max)
end